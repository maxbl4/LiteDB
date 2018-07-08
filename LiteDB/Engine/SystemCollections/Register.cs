﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiteDB.Engine
{
    public partial class LiteEngine
    {
        /// <summary>
        /// Register all internal system collections avaiable by default
        /// </summary>
        private void InitializeSystemCollections()
        {
            this.RegisterSystemCollection("$database", () => this.SysDatabase());

            this.RegisterSystemCollection("$cols", () => this.SysCols());
            this.RegisterSystemCollection("$indexes", () => this.SysIndexes());

            this.RegisterSystemCollection("$dump", () => this.SysDumpData());
            this.RegisterSystemCollection("$dump_wal", () => this.SysDumpWal());

            this.RegisterSystemCollection("$cache", () => this.SysCache());
            this.RegisterSystemCollection("$cache_wal", () => this.SysCacheWal());

            this.RegisterSystemCollection("$transactions", () => this.SysTransactions());
            this.RegisterSystemCollection("$snapshots", () => this.SysSnapshots());
            this.RegisterSystemCollection("$open_cursors", () => this.SysOpenCursors());
        }
    }
}