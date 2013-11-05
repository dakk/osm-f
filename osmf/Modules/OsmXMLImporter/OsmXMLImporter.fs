namespace osmf.Modules.OsmXMLImporter
    open osmf.Modules
    open osmf.StreetsGraph
    
    ///<summary>Parser for osmxml files</summary>
    type OsmXMLImporter () as this =
        inherit IModule ()
        do
            this.Name <- "OsmXMLImporter"
        
        static member Import (path : string) =
            let sgraph = new StreetsGraph ()            
            (sgraph)
