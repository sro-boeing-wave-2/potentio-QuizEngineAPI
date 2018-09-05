using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizServer.Models
{
    public class ConnectionMapping
    {
        private readonly Dictionary<string , int> _connections =
    new Dictionary<string, int>();

        public int Count
        {
            get
            {
                return _connections.Count;
            }
        }

        public void Add(string connectionId, int userId)
        {
               
                    _connections.Add(connectionId, userId);
              
        }

        //public string GetConnections(int key)
        //{
        //    string connections;
        //    if (_connections.TryGetValue(key, out connections))
        //    {
        //        return connections;
        //    }

        //    return null;
        //}
        public int GetuserId(string connection)
        {
            //int userId;
            //foreach (KeyValuePair<string, int> item in _connections)
            // {
            //     if (item.Value == connection)
            //         return item.Key;
            // }
            // return 0;
           int userId =  _connections.GetValueOrDefault(connection);
            return userId;

        }

        //public void Remove(int key, string connectionId)
        //{
        //    lock (_connections)
        //    {
        //        HashSet<string> connections;
        //        if (!_connections.TryGetValue(key, out connections))
        //        {
        //            return;
        //        }

        //        lock (connections)
        //        {
        //            connections.Remove(connectionId);

        //            if (connections.Count == 0)
        //            {
        //                _connections.Remove(key);
        //            }
        //        }
        //    }
        //}

    }
}
