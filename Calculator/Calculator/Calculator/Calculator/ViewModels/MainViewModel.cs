using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public MainViewModel()
		{
			
			TotalCommand = new Command<string>(OnTotalButtonClicked);
			GetNumber = new Command<string>(AddNumber);
			ClearInputs = new Command(ResetCalculator);
			OppositeNumber = new Command(ConvertNumber);

		}

		private void ConvertNumber()
		{
			int number =int.Parse(EntryString);
			int template = number * (-1);
			EntryString = template.ToString();

		}

		private void ResetCalculator()
		{						
				totalNumber = 0;
				entryNumber = 0;
				currentOperation = 0;
	            flag = 0;		      
		        process = "";
			    AllProcess = "";
				EntryString = "";

		}

		private void AddNumber(string obj)
		{
			if (flag == 1)
			{
				EntryString = "".ToString();
				flag = 0;
			}
			EntryString += obj;
			flag2 = 1;
		}

		#region UI Methods
		private void OnTotalButtonClicked(string obj)
		{
		 if (flag2 == 1) {
			if (currentOperation == 0 && entryString != "" && int.Parse(obj) != 6)
			{
				totalNumber = long.Parse(entryString);
				AllProcess += entryString;
				process = "";
				entryString = "";
				currentOperation = int.Parse(obj);
			    flag2 = 0;
				return;
			}
			if (entryString != "" && currentOperation != 0)
			{
				entryNumber = long.Parse(entryString);
				AllProcess += CurrentProcess(currentOperation)+entryString;
				process = "";
				entryString = "";
				flag2 = 0;
			}

			switch (currentOperation)
			{
				
				case 2:   //"+"
					totalNumber = totalNumber + entryNumber;
					EntryString = totalNumber.ToString();
					flag = 1;
					currentOperation = int.Parse(obj);
					break;
				case 3:   //"-"
					totalNumber = totalNumber - entryNumber;
					EntryString = totalNumber.ToString();
					flag = 1;
					currentOperation = int.Parse(obj);
					break;
				case 4:    //"/"
					totalNumber = totalNumber / entryNumber;
					EntryString = totalNumber.ToString();
					flag = 1;
					currentOperation = int.Parse(obj);
					break;
				case 5:   //"X"
					totalNumber = totalNumber * entryNumber;
					EntryString = totalNumber.ToString();
					flag = 1;
					currentOperation = int.Parse(obj);
					break;
				default:

					currentOperation = int.Parse(obj);
					break;
			}
			if (currentOperation != 0)
			{
				if (int.Parse(obj) == 6)
				{
					currentOperation = 0;
				}
			}
	     }
		}
		#endregion


		#region Properties
		private long totalNumber = 0;
		private long entryNumber = 0;
		private int currentOperation = 0;
		private string entryString = "";
		private long result;
		private int flag = 0;
		private int flag2 = 0;
		private string allProcess = "";
		private string process = "";

		public string AllProcess
		{
			set
			{
				if (value != allProcess)
				{
					allProcess = value;
					OnPropertyChanged(nameof(AllProcess));
				}
			}
			get
			{

				return allProcess;
			}


		}
		public string EntryString
		{
			set
			{
				if (value != entryString)
				{
					entryString = value;
					OnPropertyChanged(nameof(EntryString));
				}
			}
			get
			{
				return entryString;
			}



		}
		public long Result
		{
			set
			{
				if (value != result)
				{
					result = value;
					OnPropertyChanged(nameof(Result));
				}
			}
			get
			{
				return result;
			}
		}


		public ICommand TotalCommand { protected set; get; }
		public ICommand GetNumber { protected set; get; }
		public ICommand ClearInputs { protected set; get; }
		public ICommand OppositeNumber { protected set; get; }
		
		#endregion

		private string CurrentProcess(int operation)
		{
			switch (operation)
			{
				case 1:    //"NegativePositive"
					

					break;
				case 2:   //"+"
					process += "+";
					break;
				case 3:   //"-"
					process += "-";
					break;
				case 4:    //"/"
					process += "/";
					break;
				case 5:   //"X"
					process += "*";
					break;
				default:

					break;
			}
			return process;
        }

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
