using Microsoft.EntityFrameworkCore;
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
        // get by TypePitch id
        public List<Pitch> GetByPitchId(int typePitch)
        {
            List<Pitch> list = _context.Pitches.Where(x=>x.TypePitchId == typePitch).ToList();
            return list;
        }

        // get by Id
        public List<Pitch> GetById(int id)
        {
            List<Pitch> list = _context.Pitches.Where(x=>x.Id == id).ToList();
            return list;
        }

        // get by name
        public List<Pitch> GetByName(string name)
        {
            List<Pitch> pitches = _context.Pitches.Where(x=>x.Name.Equals(name)).ToList();
            return pitches;
        }

        // add
        public void Add(Pitch pitch)
        {
            _context.Pitches.Add(pitch);
            _context.SaveChanges();
        }

        // Delete
        public void Delete(Pitch pitch)
        {
            _context.Pitches.Remove(pitch);
            _context.SaveChanges();
        }

        // Edit
        public void Edit(Pitch pitch)
        {
            _context.Entry(pitch).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
