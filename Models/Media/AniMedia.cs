﻿using CsAnilist.AnilistAPI.Enum;
using CsAnilist.Models.Enums;

namespace CsAnilist.Models.Media
{
    public class AniMedia
    {
        public int id { get; set; }
        public int idMal { get; set; }
        public Title? title { get; set; }
        public string? type { get; set; }
        public MediaFormat format { get; set; }
        public MediaStatus status { get; set; }
        public string? description { get; set; }
        public StartDate? startDate { get; set; }
        public EndDate? endDate { get; set; }
        public int? episodes { get; set; }
        public int? chapters { get; set; }
        public int? volumes { get; set; }
        public CoverImage? coverImage { get; set; }
        public string? bannerImage { get; set; }
        public int? averageScore { get; set; }
        public int? meanScore { get; set; }
        public string? season { get; set; }
        public List<string>? genres { get; set; }
        public string? source { get; set; }
        public string? siteUrl { get; set; }
        public int? duration { get; set; }
        public AiringSchedule? airingSchedule { get; set; }
        public int favourites { get; set; }
        public MediaTrailer? trailer { get; set; }
    }
}
