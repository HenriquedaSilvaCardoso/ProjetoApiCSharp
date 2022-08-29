using Data.Context;
using Data.Model;
using System.Collections.Generic;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T model)
        {
          using (ProjetoContext projetoContext = new ProjetoContext())
            {
                projetoContext.Set<T>().Add(model);
                projetoContext.SaveChanges();
            }
            return "Registro criado com sucesso!";
        }

        public string Delete(int id)
        {
            var model = this.GetById(id);
            using (ProjetoContext context = new ProjetoContext())
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
            return "Deletado";
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using(ProjetoContext projetoContext = new ProjetoContext())
            {
                list = projetoContext.Set<T>().ToList();
            }
            return list;
        }

        public virtual T GetById(int id)
        {
            T model = null;
            using (ProjetoContext context = new ProjetoContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Update(T model)
        {
            using (ProjetoContext context = new ProjetoContext())
            {
                context.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Atualizado";
        }
    }
}
