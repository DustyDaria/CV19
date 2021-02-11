using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels.Base
{
    // Базовый класс модели-представления
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        //!!!!! -> Данный шаблон необходим всегда для обработки событий
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        // Задача у данного метода: обновлять значения свойства, для кот. определено поле, в кот. это свойство хранит данные
        // Разрешает задачу кольцевых обновлений свойств
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
        //!!!!! -> 



        ///////////////
        /// Интерфейс IDisposable для примера реализации (в данном шаблоне не обязателен)
        /// 


        // Деструктор
        /*~ViewModel()
        {
            Dispose(false);
        }*/

        public void Dispose()
        {
            Dispose(true);
        }

        private bool _Disposed;
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
            // Освобождение управляемых ресурсов
        }
    }
}
