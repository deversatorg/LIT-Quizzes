﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Common.Attributes
{
    public class TrimmedStringLengthAttribute : StringLengthAttribute
    {
        public TrimmedStringLengthAttribute(int maximumLength) : base(maximumLength)
        {
        }

        /// <summary>
        /// Returns true if string are in the specified interval
        /// </summary>
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            if (!(value is string))
                return false;

            var valueString = value as string;

            if (valueString.Trim().Length > MaximumLength || valueString.Trim().Length < MinimumLength)
                return false;

            return true;
        }
    }
}
