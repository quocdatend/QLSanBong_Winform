using QLSanBong.DAL;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class SessionBus
    {
        Session _session = new Session();
        public Session Session { get { return _session; } }
        // Add
        public void Add(Session session) { _session = session; }
        // Delete
        public void Delete(Session session) { _session = session; }
        // Get
        public Session  GetSession() { return _session; }
    }
}
