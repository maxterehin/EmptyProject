using System;
using System.Collections.Generic;
using System.Text;

namespace EmptyProject.Database.DbModels
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}
