            ChunkList selectedChunks = ChunkList.GetSelectedChunks(text, selectionPosition, selectionLength, out var header);
            {
            }
            {
            }
            {
            }
            {
            }
        public static byte[] GetSelectedLinesAsPatch(string text, int selectionPosition, int selectionLength, bool staged, Encoding fileContentEncoding, bool isNewFile)
            ChunkList selectedChunks = ChunkList.GetSelectedChunks(text, selectionPosition, selectionLength, out var header);
            {
            }
            {
            }
            {
            }

            string[] headerLines = header.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            {
                {
                }
            }
                {
                }
                {
                }
        public static byte[] GetSelectedLinesAsNewPatch(GitModule module, string newFileName, string text, int selectionPosition, int selectionLength, Encoding fileContentEncoding, bool reset, byte[] filePreabmle)
            const string fileMode = "100000"; // given fake mode to satisfy patch format, git will override this

            {
            }
            {
            }

            ChunkList selectedChunks = ChunkList.FromNewFile(module, text, selectionPosition, selectionLength, reset, filePreabmle, fileContentEncoding);
            {
            }

            {
            }
            {
            }
            {
            }
            var s = new StringBuilder();

            byte[] bs = Encoding.UTF8.GetBytes(input);
            {
            }
                {
                }
        public string Text { get; private set; }
        public PatchLine(string text, bool selected = false)
        {
            Text = text;
            Selected = selected;
        }

            return new PatchLine(Text, Selected);
        public List<PatchLine> PreContext { get; } = new List<PatchLine>();
        public List<PatchLine> RemovedLines { get; } = new List<PatchLine>();
        public List<PatchLine> AddedLines { get; } = new List<PatchLine>();
        public List<PatchLine> PostContext { get; } = new List<PatchLine>();
        public string WasNoNewLineAtTheEnd { get; set; }
        public string IsNoNewLineAtTheEnd { get; set; }
            {
            }
                    {
                    }
                    {
                    }

                    {
                    }
                    {
                    }

            {
            }

            {
            }

            {
            }

            {
            }
            {
            }
                    {
                    }
                    {
                    }

            {
            }

            {
            }

            {
            }
            {
            }
        private int _startLine;
        private readonly List<SubChunk> _subChunks = new List<SubChunk>();
        private SubChunk _currentSubChunk;
                if (_currentSubChunk == null)
                    _currentSubChunk = new SubChunk();
                    _subChunks.Add(_currentSubChunk);

                return _currentSubChunk;
            {
            }
            {
            }
            {
                _currentSubChunk = null; // start new SubChunk
            }
            {
            }
            {
            }
            return int.TryParse(header, out _startLine);
            {
            }
                    var patchLine = new PatchLine(line);

                    {
                    }
                    {
                    }
                        {
                        }
                        {
                        }
                    {
                    }
        public static Chunk FromNewFile(GitModule module, string fileText, int selectionPosition, int selectionLength, bool reset, byte[] filePreabmle, Encoding fileContentEncoding)
            Chunk result = new Chunk { _startLine = 0 };

            {
            }
            {
            }
            {
            }
            string[] lines = fileText.Split(new[] { eol }, StringSplitOptions.None);
                string preamble = i == 0 ? new string(fileContentEncoding.GetChars(filePreabmle)) : string.Empty;
                var patchLine = new PatchLine((reset ? "-" : "+") + preamble + line);

                // do not refactor, there are no breakpoints condition in VS Express
                {
                }
                            PatchLine lastNotSelectedLine = result.CurrentSubChunk.RemovedLines.LastOrDefault(l => !l.Selected);

                {
                }

            foreach (SubChunk subChunk in _subChunks)
            {
            }
            diff = "@@ -" + _startLine + "," + removedCount + " +" + _startLine + "," + addedCount + " @@".Combine("\n", diff);
        public static ChunkList GetSelectedChunks(string text, int selectionPosition, int selectionLength, out string header)

            {
            }
            {
            }
            string[] chunks = diff.Split(new[] { "\n@@" }, StringSplitOptions.RemoveEmptyEntries);

                    {
                    }

        public static ChunkList FromNewFile(GitModule module, string text, int selectionPosition, int selectionLength, bool reset, byte[] filePreabmle, Encoding fileContentEncoding)
            return new ChunkList
            {
                Chunk.FromNewFile(
                    module,
                    text,
                    selectionPosition,
                    selectionLength,
                    reset,
                    filePreabmle,
                    fileContentEncoding)
            };
            {
            }
