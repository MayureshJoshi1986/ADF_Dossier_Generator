﻿using Sahadeva.Dossier.DAL;
using Sahadeva.Dossier.Entities;

namespace Sahadeva.Dossier.DocumentGenerator.Messaging
{
    /// <summary>
    /// A helper class that is used for local development to avoid the need to run the dossier job generator
    /// </summary>
    internal class DevJobFetcher : IJobFetcher
    {
        private readonly DossierDAL _dal;

        public DevJobFetcher(DossierDAL dal)
        {
            _dal = dal;
        }

        public Task<DossierJob?> ReceiveMessage()
        {
            var dossierJobs = new DossierDAL().FetchPending_DCIDsToProcess_All();

            if (dossierJobs.Rows.Count > 0)
            {
                var job = dossierJobs.Rows[0];
                return Task.FromResult<DossierJob?>(new DossierJob(
                    Guid.NewGuid().ToString(),
                    Convert.ToString(job["TemplateName"]),
                    Convert.ToInt32(job["DDID"]),
					//Convert.ToString(job["GeneratedFileLocation"])

					"D:\\Shubham All Files\\Projects\\WordAutomation Arnold GithubCode 29Oct2024\\Sahadev_Dossier-main\\Sahadev_Dossier-main\\result",
					Convert.ToString(job["TagIds"])
					));
            }

            return Task.FromResult<DossierJob?>(null);
        }
    }
}
