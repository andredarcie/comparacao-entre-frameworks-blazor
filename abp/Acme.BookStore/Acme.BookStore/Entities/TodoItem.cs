﻿using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.Entities
{
    public class TodoItem : BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
