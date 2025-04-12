﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Shared.Interfaces
{
    public interface IReadonlyObjectDTO<T>
    {
        public T Id { get; }
        //public DateTime CreatedAt { get; }
    }
}
