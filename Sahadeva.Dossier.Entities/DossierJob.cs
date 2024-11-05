using System;

namespace Sahadeva.Dossier.Entities
{
    public class DossierJob
    {
        public DossierJob(string runId, string templateName, int coverageDossierId, string outputFilePath, string TagId)
        {
            Timestamp = DateTime.UtcNow;
            RunId = runId;
            TemplateName = templateName;
            CoverageDossierId = coverageDossierId;
            OutputFilePath = outputFilePath;
            TagIds = TagId;

		}

        public string RunId { get; private set; }

        public DateTime Timestamp { get; private set; }

        public int CoverageDossierId { get; private set; }

        public string TemplateName { get; private set; }

        public string OutputFilePath { get; private set; }

		public string TagIds { get; private set; }
	}
}
