using System;

namespace DoAnDemo
{
    public class SaveCompleteEventArgs : EventArgs
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object SavedEntity { get; set; } 

        public SaveCompleteEventArgs(bool success)
        {
            Success = success;
        }

        public SaveCompleteEventArgs(bool success, string message = "", object savedEntity = null)
        {
            Success = success;
            Message = message;
            SavedEntity = savedEntity;
        }
    }
}
