﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SE214L22.Core.ViewModels.Settings
{
    public class NameValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string name = (string)value;
            if (value == null || name.Trim().Length == 0)
            {
                return new ValidationResult(false, "Vui lòng nhập tên");
            }
            return ValidationResult.ValidResult;
        }
    }
}
