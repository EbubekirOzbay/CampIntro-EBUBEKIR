using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    //constructor bir class ' new=lendiğinde çalışan bloğa denir
    //items.Length-dizinin eleman sayısı
    //tempArray geçici dizi
    {

        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)

        {
            T[] tempArray = items;

            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            
       }
    }
        

        
    
}
