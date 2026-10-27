using AutoApi.Data;
using AutoApi.Models;

namespace AutoApi.Services
{
    public class AutoService
    {
        private readonly AppDbContext _context;

        public AutoService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateAuto()
        {
            _context.Database.EnsureCreated();
        }

        public Auto AddAuto(Auto auto)
        {
            _context.Autos.Add(auto);
            _context.SaveChanges();

            return auto;
        }

        public Auto? ReturnAuto(int id)
        {
            return _context.Autos.FirstOrDefault(a => a.Id == id);
        }

        public List<Auto> ReturnByName(string name)
        {
            return _context.Autos.Where(a => a.Name.Contains(name)).ToList();
        }

        public List<Auto> ReturnByYear(int year)
        {
            return _context.Autos.Where(a => a.Year == year).ToList();
        }

        public List<Auto> ShowAll()
        {
            return _context.Autos.ToList();
        }
    }
}