namespace SourceControlSystem.Web.Api.Controllers
{
    using Data;
    using Models.Projects;
    using Common;
    using SourceControlSystem.Models;
    using System;
    using System.Linq;
    using System.Web.Http;
    using Services.Data;

    public class ProjectsController : ApiController
    {
        private ProjectsService projects;
        private EfGenericRepository<User> users;

        public ProjectsController()
        {
            projects = new ProjectsService();
        }

        public IHttpActionResult Get()
        {
            var result = this.projects
                         .All()
                         .Select(SoftwareProjectDetailsModel.FromModel)
                         .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return this.BadRequest("Name cannot be null or empty!");
            }

            var result = this.projects.All()
                         .Where(p => p.Name == name && !p.IsPrivate 
                         || p.IsPrivate && p.Users.Any(u => u.UserName == this.User.Identity.Name))
                         .Select(SoftwareProjectDetailsModel.FromModel)
                         .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        [Route("api/projects/all")]
        public IHttpActionResult Get(int page = 1, int pageSize = GlobalConstants.DefaultPageSize)
        {
            var result = this.projects
                         .All(page, pageSize)
                         .Select(SoftwareProjectDetailsModel.FromModel)
                         .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Post(SaveProjectRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdProjectId = this.projects.Add(model.Name, model.Description, this.User.Identity.Name, model.IsPrivate);
            return this.Ok(createdProjectId);
        }
    }
}
