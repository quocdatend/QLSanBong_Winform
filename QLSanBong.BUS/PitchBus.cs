using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class PitchBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public PitchBus() { }
        // get all
        public List<Pitch> GetAll()
        {
            return _context.Pitches.ToList();
        }
        // add
        public void add(Pitch pitch)
        {
            _context.Pitches.Add(pitch);
            _context.SaveChanges();
        }
        // get by name
        public List<Pitch> GetByPitchId(int typePitch)
        {
            List<Pitch> list = _context.Pitches.Where(x=>x.TypePitchId == typePitch).ToList();
            return list;
        }
    }
}
