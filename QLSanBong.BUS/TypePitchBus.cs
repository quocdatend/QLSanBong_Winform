using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class TypePitchBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public TypePitchBus() { }
        // get all
        public List<TypePitch> GetAll()
        {
            return _context.TypePitches.ToList();
        }

        // Add 
        public void Add(TypePitch typePitch)
        {
            _context.TypePitches.Add(typePitch);
            _context.SaveChanges();
        }
        // get by name
        public List<TypePitch> GetByName(string name)
        {
            List<TypePitch> list = _context.TypePitches.Where(x => x.Name.Equals(name)).ToList();
            return list;
        }

        // get by id
        public List<TypePitch> GetById(int id)
        {
            List<TypePitch> list = _context.TypePitches.Where(x => x.Id == id).ToList();
            return list;
        }
    }
}
