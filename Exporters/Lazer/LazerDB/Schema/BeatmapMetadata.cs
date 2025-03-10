﻿// Original source file (modified by kabii) Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
using Realms;

namespace BeatmapExporter.Exporters.Lazer.LazerDB.Schema
{
    public class BeatmapMetadata : RealmObject
    {
        public string Title { get; set; } = string.Empty;
        public string TitleUnicode { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string ArtistUnicode { get; set; } = string.Empty;
        public RealmUser Author { get; set; } = new RealmUser();
        public string Source { get; set; } = string.Empty;
        public string? Tags { get; set; } = string.Empty;
        public int PreviewTime { get; set; }
        public string AudioFile { get; set; } = string.Empty;
        public string BackgroundFile { get; set; } = string.Empty;

        // Author kabii
        public string OutputAudioFilename(int beatmapId) =>
            $"{Artist.Trunc(30)} - {Title.Trunc(60)} ({beatmapId}).mp3"
            .RemoveFilenameCharacters();
    }
}
