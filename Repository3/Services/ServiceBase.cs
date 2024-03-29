﻿using Microsoft.EntityFrameworkCore;
using Repository3.Models;



namespace Repository.Service
{
    public class ServiceBase<T> where T : class
    {
        private readonly FileCsvContext _context;
        private readonly DbSet<T> _dbSet;

        public ServiceBase(FileCsvContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Add(T entity)
        {
            using (_context)
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
            }
        }
        public bool Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public List<T> SearchByKeyword(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public bool AddMany(IEnumerable<T> entities)
        {
            try
            {
                _dbSet.BulkInsert(entities);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public void AddManyRecord(List<T> entities)
        {
            _dbSet.AddRange(entities);
            _context.SaveChanges();
        }
    }
}