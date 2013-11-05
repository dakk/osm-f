namespace StreetsGen.StreetsGraph

        
    type Way (id:int, visible:bool) = 
        inherit MapObject (id, visible)
        
        member val public Name      : string = ""           with get, set
        member val public Oneway    : bool = false          with get, set
        member val public Nodes     : int list = []      with get, set
        
        override this.ToString () =
            let mutable s = sprintf "\t<way id='%d' visible='%s' version='1'>\n" this.Id (if this.Visible then "true" else "false")
            for node in this.Nodes do s <- s + (sprintf "\t\t<nd ref='%d'/>\n" node)
            (s + this.TagsToString () + "\t</way>\n")
            

