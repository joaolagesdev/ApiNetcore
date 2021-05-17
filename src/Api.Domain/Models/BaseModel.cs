using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class BaseModel
    {
        private Guid id;
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime createdAt;
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value == null ? DateTime.UtcNow : value; }
        }

        private DateTime updateAt;
        public DateTime UpdateAt
        {
            get { return updateAt; }
            set { updateAt = value == null ? DateTime.UtcNow : value; }
        }
    }
}
