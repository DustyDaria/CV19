﻿using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title = "Анализ статистики CV19";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;

            /*set
            {
                if (Equals(_Title, value)) return;
                _Title = value;
                OnPropertyChanged();

                /// Содержимое метода можно сократить до 1 строки
                Set(ref _Title, value); 

            }*/

            // set{} можно сократить до одной строки
            set => Set(ref _Title, value);
        }
        #endregion

    }
}
