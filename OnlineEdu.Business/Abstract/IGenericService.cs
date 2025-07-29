using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
	public interface IGenericService<T> where T : class// T, class  //T sınıfı olmak zorunda
	{
		/*dataaccess ıcınde ırepositorydekı kodların aynısı burada var karısmasın dıye baslarına T eklendı*/
		List<T> TGetList();
		T TGetByFilter(Expression<Func<T, bool>> predicate);//sarta gore tek bır deger getırme ısıne yarar
		T TGetById(int id);
		void TCreate(T entity);
		void TUpdate(T entity);
		void TDelete(int id);
		int TCount();
		int TFilteredCount(Expression<Func<T, bool>> predicate);//sarta gore butun sayıların degerini getırme ısıne yarar
		List<T> TGetFilteredList(Expression<Func<T, bool>> predicate);//sarta gore butun degeri getırme ısıne yarar
	}
}
