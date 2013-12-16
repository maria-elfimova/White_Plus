﻿using White.Core.UIItems.Finders;
using System.Text;
using White.Core;
using System.Windows.Controls;
using White.Core.UIItems;
using White.Core.UIItems.WindowItems;
using ViewAccessors;

namespace _MathService
{
    public class MathService
    {
        private Window window;
        public MathService(Window window)
        {
            this.window = window;
        }

        public string CalculationDecomposition(string number)
        {
            var accessor = new MainWindowAccessor(window);
            accessor.Number.Text = number;
            accessor.DecomposeButton.Click();
            string result = accessor.Answer.Text;
            return result;
        }

        public string CalculationPhiFunction(string number)
        {
            var accessor = new MainWindowAccessor(window);
            accessor.MoreFunctions.Click();
            DialogAccessor<MainWindowAccessor> dialogAccessor = accessor.getDialog();
            dialogAccessor.accessor.comboBox.Select("Phi function");
            dialogAccessor.accessor.SecondTextBox.Text = number;
            dialogAccessor.accessor.Calculation.Click();
            string result = dialogAccessor.accessor.AnsForComboBox.Text;
            return result;
        }
    }
}