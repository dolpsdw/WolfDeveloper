// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProjectRepository.cs" company="Wolf">
//   Jesús González Gómez
// </copyright>
// <summary>
//   Defines the Contract for ProjectRepository class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System.Collections.Generic;

    using Models;

    /// <summary>
    /// Interface IProjectRepository
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Gets the project from Database
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>new Project.</returns>
        Project GetProject(int id);

        /// <summary>
        /// Gets all projects from Database
        /// </summary>
        /// <returns>new List&lt;Project&gt;.</returns>
        List<Project> GetAllProjects();

        /// <summary>
        /// Deletes the project.
        /// </summary>
        /// <param name="project">The project.</param>
        void DeleteProject(Project project);

        /// <summary>
        /// Updates the project.
        /// </summary>
        /// <param name="project">The project.</param>
        void UpdateProject(Project project);

        /// <summary>
        /// Adds a new project.
        /// </summary>
        /// <param name="project">The project.</param>
        void AddProject(Project project);
    }
}