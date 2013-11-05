namespace osmf.StreetsGraph
    open osmf.Utility
    
    open System.IO
    open System
    
    ///<summary>Class that represent an OSM map</summary>
    type StreetsGraph () = 
        // Switch to indexed arrays
        member val public Nodes     : Node list = []      with get, set
        member val public Ways      : Way list = []       with get, set
        member val public Relations : Relation list = []  with get, set
     
            
        ///<summary>Return the osmxml data</summary>
        override this.ToString () =
            let mutable s = "<?xml version='1.0' encoding='UTF-8'?>\n"
            s <- s + "<osm version='0.6' generator='osmf 1.0'>\n"
            for node in this.Nodes do s <- s + (node.ToString ())
            for way in this.Ways do s <- s + (way.ToString ())
            for relation in this.Relations do s <- s + (relation.ToString ())
            s + "</osm>\n"
            
            
        ///<summary>Save the streetsgraph to an xml file</summary>
        member this.SaveToXML (path:string) = 
            File.WriteAllText(path, this.ToString ())
