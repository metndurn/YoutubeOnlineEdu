﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Repositories
{/*yeni yapıda dırek context sınıfını generıcrepository ıcıne koyunca oluyor*/
	public class GenericRepository<T>(OnlineEduContext _context) : IRepository<T> where T : class
	{
		public DbSet<T> Table { get => _context.Set<T>(); }
		public int Count()
		{
			return Table.Count();
		}

		public void Create(T entity)
		{
			Table.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = Table.Find(id);
			Table.Remove(entity);
			_context.SaveChanges();
		}

		public int FilteredCount(Expression<Func<T, bool>> predicate)
		{
			return Table.Where(predicate).Count();/*where sarti ile sartımızın sayısını almıs olduk*/
		}

		public T GetByFilter(Expression<Func<T, bool>> predicate)
		{
			return Table.Where(predicate).FirstOrDefault();/*where sarti ile sartımızın tek bir degerini almıs olduk*/
		}

		public T GetById(int id)
		{
			return Table.Find(id);
		}

		public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
		{
			return Table.Where(predicate).ToList();/*where sarti ile sartımızın listesini almıs olduk*/
		}

		public List<T> GetList()
		{
			return Table.ToList();
		}

		public void Update(T entity)
		{
			Table.Update(entity);
		}
	}
}
