﻿using System.ComponentModel.DataAnnotations;

namespace Spiderly.Shared.Interfaces
{
    public interface IBusinessObject<T> where T : struct
    {
        public T Id { get; }
        public int Version { get; }

        public DateTime CreatedAt { get; }
        public DateTime ModifiedAt { get; }
    }
}
