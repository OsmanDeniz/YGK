using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        /// <summary>
        /// Bellege veri ekleme
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        /// <param name="duration">Bellekte ne kadar süre saklanacak</param>
        void Add(string key, object value, int duration); 

        /// <summary>
        /// Bir tipte veri getirme
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns>T</returns>
        T Get<T>(string key);

        /// <summary>
        /// Object tipte veri getirme
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Object</returns>
        object Get(string key);

        /// <summary>
        /// Bellekte yer aliyor mu?
        /// </summary>
        /// <param name="key"></param>
        /// <returns> True/False </returns>
        bool IsAdd(string key);

        /// <summary>
        /// Bellekten silme
        /// </summary>
        /// <param name="key">Silinmesi istenen verinin keyi</param>
        void Remove(string key);

        /// <summary>
        /// Bir kurala gore bellekten silme
        /// </summary>
        /// <param name="pattern">Silme filtresi</param>
        void RemoveByPattern(string pattern);
    }
}
