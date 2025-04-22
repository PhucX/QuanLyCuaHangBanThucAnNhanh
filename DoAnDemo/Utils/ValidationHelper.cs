using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace DoAnDemo.Utils
{
    public static class ValidationHelper
    {
        private static readonly Dictionary<Control, Timer> _validationTimers = new Dictionary<Control, Timer>();
        private static readonly object _lockObject = new object();

        public static void SetupDebouncedValidation(Control control, Action validationAction, int delayMs = 300)
        {
            lock (_lockObject)
            {
                if (_validationTimers.ContainsKey(control))
                {
                    _validationTimers[control].Dispose();
                }

                var timer = new Timer();
                timer.Interval = delayMs;
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    validationAction();
                };

                _validationTimers[control] = timer;

                control.TextChanged += (s, e) =>
                {
                    timer.Stop();
                    timer.Start();
                };

                control.Disposed += (s, e) =>
                {
                    lock (_lockObject)
                    {
                        if (_validationTimers.ContainsKey(control))
                        {
                            _validationTimers[control].Dispose();
                            _validationTimers.Remove(control);
                        }
                    }
                };
            }
        }

        public static bool ValidateDecimalRange(string value, decimal min, decimal max, out decimal result)
        {
            if (decimal.TryParse(value.Replace(",", ""), out result))
            {
                return result >= min && result <= max;
            }
            return false;
        }

        public static bool ValidateRequiredField(Control control, ErrorProvider errorProvider, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider.SetError(control, errorMessage);
                return false;
            }
            
            errorProvider.SetError(control, "");
            return true;
        }

        public static bool ValidateDate(DateTime value, DateTime min, DateTime max, ErrorProvider errorProvider, Control control, string errorMessage)
        {
            if (value < min || value > max)
            {
                errorProvider.SetError(control, errorMessage);
                return false;
            }

            errorProvider.SetError(control, "");
            return true;
        }

        public static void ClearValidationState()
        {
            lock (_lockObject)
            {
                foreach (var timer in _validationTimers.Values)
                {
                    timer.Dispose();
                }
                _validationTimers.Clear();
            }
        }
    }
}