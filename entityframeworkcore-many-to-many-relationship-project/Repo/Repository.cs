using entityframeworkcore_many_to_many_relationship_project.Data;
using entityframeworkcore_many_to_many_relationship_project.Models;
using Microsoft.EntityFrameworkCore;

namespace entityframeworkcore_many_to_many_relationship_project.Repo
{
    public class Repository
    {
        private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<List<Subject>> GetSubjects()
        {
            return await _appDbContext.Subjects.Include(s => s.Students).ToListAsync();
        }

        public async Task AddSubject(Subject subject)
        {
            await _appDbContext.Subjects.AddAsync(subject);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _appDbContext.Students.Include(s => s.Subjects).ToListAsync();
        }

        public async Task AddStudent(Student student)
        {
            await _appDbContext.AddAsync(student);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
