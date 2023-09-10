﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Enum
{
    public enum Priority
    {
        [Display(Name = "Несрочная")]
        Easy = 1,
        [Display(Name = "Умеренная")]
        Medium = 2,
        [Display(Name = "Критичная")]
        Hard = 3
    }
}
