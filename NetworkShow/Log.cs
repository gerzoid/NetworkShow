using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NetworkShow
{
    public class LogWriter
    {
        private static LogWriter instance;
        private static Queue<Log> logQueue;
        private static string logDir = "Log";
        private static string logFile = "netwokshow.log";
        private static int maxLogAge = int.Parse("2");
        private static int queueSize = int.Parse("3");
        private static DateTime LastFlushed = DateTime.Now;

        /// <summary>
        /// Закрытый конструктор для предотвращения создания новых экземпляров
        /// </summary>
        private LogWriter() { }

        /// <summary>
        /// Единственный экземпляр Log
        /// </summary>
        public static LogWriter Instance
        {
            get
            {                
                if (instance == null)
                {
                    instance = new LogWriter();
                    logQueue = new Queue<Log>();
                }
                return instance;
            }
        }

        /// <summary>
        /// Единственный метод для записи в лог файл
        /// </summary>
        /// <param name="message">Сообщения для записи в Log</param>
        public void WriteToLog(string message)
        {
            // Lock the queue while writing to prevent contention for the log file
            lock (logQueue)
            {
                // Create the entry and push to the Queue
                Log logEntry = new Log(message);
                logQueue.Enqueue(logEntry);

                // If we have reached the Queue Size then flush the Queue
                if (logQueue.Count >= queueSize || DoPeriodicFlush())
                {
                    FlushLog();
                }
            }            
        }

        private bool DoPeriodicFlush()
        {
            TimeSpan logAge = DateTime.Now - LastFlushed;
            if (logAge.TotalSeconds >= maxLogAge)
            {
                LastFlushed = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Очищаем очередь
        /// </summary>
        private void FlushLog()
        {
            while (logQueue.Count > 0)
            {
                Log entry = logQueue.Dequeue();
                string logPath = logDir + entry.LogDate + "_" + logFile;
                using (FileStream fs = File.Open(logPath, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter log = new StreamWriter(fs))
                    {
                        log.WriteLine(string.Format("{0}\t{1}",entry.LogTime,entry.Message));
                    }
                }
            }            
        }
    }

    /// <summary>
    /// A Log class to store the message and the Date and Time the log entry was created
    /// </summary>
    public class Log
    {
        public string Message { get; set; }
        public string LogTime { get; set; }
        public string LogDate { get; set; }

        public Log(string message)
        {
            Message = message;
            LogDate = DateTime.Now.ToString("yyyy-MM-dd");
            LogTime = DateTime.Now.ToString("hh:mm:ss.fff tt");
        }
    }
}

