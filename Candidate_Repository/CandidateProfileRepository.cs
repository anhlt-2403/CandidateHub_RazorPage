﻿using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class CandidateProfileRepository : ICandidateProfileRepository
    {
        public CandidateProfile GetCandidateProfileById(string id) => CandidateProfileDAO.Instance.GetCandidateProfileById(id);

        public List<CandidateProfile> GetCandidateProfiles() => CandidateProfileDAO.Instance.GetCandidateProfiles();

        public Boolean AddCandidateProfile(CandidateProfile profile) => CandidateProfileDAO.Instance.AddCandidateProfile(profile);

        public Boolean UpdateCandidateProfile(CandidateProfile profile) => CandidateProfileDAO.Instance.UpdateCandidateProfile(profile);

        public Boolean DeleteCandidateProfile(CandidateProfile profile) => CandidateProfileDAO.Instance.DeleteCandidateProfile(profile);
    }
}