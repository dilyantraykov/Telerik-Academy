using SourceControlSystem.Models;
using System;
using System.Linq.Expressions;

namespace SourceControlSystem.Web.Api.Models.Projects
{
    public class SoftwareProjectDetailsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TotalUsers { get; set; }

        public static Expression<Func<SoftwareProject, SoftwareProjectDetailsModel>> FromModel
        {
            get
            {
                return p => new SoftwareProjectDetailsModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    CreatedOn = p.CreatedOn,
                    TotalUsers = p.Users.Count
                };
            }
        }
    }
}