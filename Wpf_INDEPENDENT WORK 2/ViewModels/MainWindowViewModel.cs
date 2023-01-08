using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_INDEPENDENT_WORK_2.Models;

namespace Wpf_INDEPENDENT_WORK_2.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;//событие для уведоиления представления о том что необходимо обновить отображение

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)//реализовываем событие через метод Invoke
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        //свойство для получения контента из кнопок
        private string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }
        //свойство для вывода результата
        private string result;
        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }
        //создаем команды для передачи контента из кнопок
        public ICommand OnCommand_But_0 { get; }
        private void OnCommand_But_0_Execute(object p) { Text += "0"; }
        public ICommand OnCommand_But_1 { get; }
        private void OnCommand_But_1_Execute(object p) { Text += "1"; }
        public ICommand OnCommand_But_2 { get; }
        private void OnCommand_But_2_Execute(object p) { Text += "2"; }
        public ICommand OnCommand_But_3 { get; }
        private void OnCommand_But_3_Execute(object p) { Text += "3"; }
        public ICommand OnCommand_But_4 { get; }
        private void OnCommand_But_4_Execute(object p) { Text += "4"; }
        public ICommand OnCommand_But_5 { get; }
        private void OnCommand_But_5_Execute(object p) { Text += "5"; }
        public ICommand OnCommand_But_6 { get; }
        private void OnCommand_But_6_Execute(object p) { Text += "6"; }
        public ICommand OnCommand_But_7 { get; }
        private void OnCommand_But_7_Execute(object p) { Text += "7"; }
        public ICommand OnCommand_But_8 { get; }
        private void OnCommand_But_8_Execute(object p) { Text += "8"; }
        public ICommand OnCommand_But_9 { get; }
        private void OnCommand_But_9_Execute(object p) { Text += "9"; }
        public ICommand OnCommand_But_Plus { get; }
        private void OnCommand_But_Plus_Execute(object p) { Text += "+"; }
        public ICommand OnCommand_But_Minus { get; }
        private void OnCommand_But_Minus_Execute(object p) { Text += "-"; }
        public ICommand OnCommand_But_Mult { get; }
        private void OnCommand_But_Mult_Execute(object p) { Text += "*"; }
        public ICommand OnCommand_But_Div { get; }
        private void OnCommand_But_Div_Execute(object p) { Text += "/"; }
        //создаем команду для очистки строки
        public ICommand Command_Clear { get; }
        private void OnCommand_Clear_Execute(object p)
        {
            if (Text.Length > 0)
            {
                Text = Text.Remove(0);
            }
        }
        //создаем команду для вычисления результата
        public ICommand ResultCommand { get; }//используется только для чтения, поэтому сеттер не прописываем
        private void OnResultCommandExecute(object p)//создаем метод, который передадим в execute
        {
            Result = Calculation.GetResult(Text);//вызываем класс из папки Models и метод, вычисляющий результат
            Text += "=" + Result;
        }
        private bool OnAddCanExecuted(object p)
        {
            return true;
        }

        //создаем конструктор для инициализации команд
        public MainWindowViewModel()
        {
            ResultCommand = new RelayCommand(OnResultCommandExecute, OnAddCanExecuted);

            Command_Clear = new RelayCommand(OnCommand_Clear_Execute, OnAddCanExecuted);

            OnCommand_But_0 = new RelayCommand(OnCommand_But_0_Execute, OnAddCanExecuted);
            OnCommand_But_1 = new RelayCommand(OnCommand_But_1_Execute, OnAddCanExecuted);
            OnCommand_But_2 = new RelayCommand(OnCommand_But_2_Execute, OnAddCanExecuted);
            OnCommand_But_3 = new RelayCommand(OnCommand_But_3_Execute, OnAddCanExecuted);
            OnCommand_But_4 = new RelayCommand(OnCommand_But_4_Execute, OnAddCanExecuted);
            OnCommand_But_5 = new RelayCommand(OnCommand_But_5_Execute, OnAddCanExecuted);
            OnCommand_But_6 = new RelayCommand(OnCommand_But_6_Execute, OnAddCanExecuted);
            OnCommand_But_7 = new RelayCommand(OnCommand_But_7_Execute, OnAddCanExecuted);
            OnCommand_But_8 = new RelayCommand(OnCommand_But_8_Execute, OnAddCanExecuted);
            OnCommand_But_9 = new RelayCommand(OnCommand_But_9_Execute, OnAddCanExecuted);
            OnCommand_But_Plus = new RelayCommand(OnCommand_But_Plus_Execute, OnAddCanExecuted);
            OnCommand_But_Minus = new RelayCommand(OnCommand_But_Minus_Execute, OnAddCanExecuted);
            OnCommand_But_Mult = new RelayCommand(OnCommand_But_Mult_Execute, OnAddCanExecuted);
            OnCommand_But_Div = new RelayCommand(OnCommand_But_Div_Execute, OnAddCanExecuted);
        }
    }
}
