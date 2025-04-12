﻿using Spiderly.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Shared.BaseEntities
{
    public class ReadonlyObject<T> : IReadonlyObject<T> where T : struct
    {
        public T Id { get; protected set; }

        //public DateTime CreatedAt { get; protected set; }

        /// <summary>
        /// Don't use the method ever, its made just for automatic change from application db context
        /// </summary>
        //public void SetCreatedAt(DateTime createdAt)
        //{
        //    CreatedAt = createdAt;
        //}
    }
}
