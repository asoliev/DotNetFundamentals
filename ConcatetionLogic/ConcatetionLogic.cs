using System;

namespace ConcatetionLogicLibrary
{
    public class ConcatetionLogic
    {
        private string username;
        public ConcatetionLogic(string username)
        {
            this.username = username;
        }

        public string Output()
        {
            return $"{DateTime.Now} Hello, {username}";
        }
    }
}
