﻿namespace Sahadeva.Dossier.Common
{
    public class DatabaseConstants
    {
        public const string ConnectionString = "ConnectionString";

		public const string ConnectionString_C2 = "ConnectionString_C2";
		public const string ConnectionString_E = "ConnectionString_E";

		// SPs
		public const string USP_FetchPending_DCIDsToProcess_All = "FetchPending_DCIDsToProcess_All_NEW";
        public const string USP_CoverageDossier_UpdateStatus = "USP_CoverageDossier_UpdateStatus";

		public const string Fetch_WordGenerationDossierDefIDs = "Fetch_WordGenerationDossierDefIDs";
		public const string Fetch_LinkIds = "Fetch_LinkIds";

		// SP Params
		public const string CDID = "CDID";
        public const string StatusID = "StatusID";

		public const string DDID = "DDID";
		public const string LPID = "LPID";
		public const string LOID = "LOID";
		public const string TAGID = "TAGID";
	}
}
