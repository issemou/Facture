using MyLibs.Serialisation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.DAL
{
    public class BaseRepository<T>
    {
        protected List<T> datas;
        protected readonly string PATH = $"Data/{typeof(T).Name}.json";
        private Serializer<List<T>> serializer;
        public BaseRepository()
        {
            datas = new List<T>();
            FileInfo fi = new FileInfo(PATH);

            if (!fi.Directory.Exists)
                fi.Directory.Create();

            serializer = new Serializer<List<T>>(Mode.JSON, PATH);
            Restore();
        }

        public int IndexOf(T Obj)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
                if (Obj.Equals(datas[i]))
                    index = i;
            return index;
        }

        public void Add(T obj)
        {
            int index = IndexOf(obj);
            if (index != -1)
                throw new DuplicateWaitObjectException($"{typeof(T).Name} already exists !");

            datas.Add(obj);
            Save();
        }

        public void Set(T oldObj, T newObj)
        {
            int oldIndex = IndexOf(oldObj);
            if (oldIndex < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found !");

            var newIndex = IndexOf(newObj);

            if (newIndex >= 0 && newIndex != oldIndex)
                throw new KeyNotFoundException($"{typeof(T).Name} already exists !");

            datas[oldIndex] = newObj;
            Save();
        }

        public void Delete(T obj)
        {
            var index = IndexOf(obj);

            if (index >= 0)
                datas.RemoveAt(index);
            Save();
        }

        public void Save()
        {
            serializer.Serialize(datas);
        }
        public void Restore()
        {
            FileInfo fi = new FileInfo(PATH);
            if (fi.Exists && fi.Length > 0)
                datas = serializer.Deserialize();
        }

        public List<T> GetAll()
        {
            Restore();
            T[] items = new T[datas.Count];
            datas.CopyTo(items);
            return items.ToList<T>();
        }
    }
}
