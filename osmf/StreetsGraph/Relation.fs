namespace osmf.StreetsGraph


    type Role =
        | Inner
        | Outer
        override this.ToString () =
            match this with
                | Inner -> "inner"
                | Outer -> "outer"

    type Relation (id:int, visible:bool) = 
        inherit MapObject (id, visible)
        
        member val public Ways  : (int*Role) list = []          with get, set
        //member val public Nodes : int list = []          with get, set
        
        member this.AddWay (id,role) =
            this.Ways <- (id,role)::(this.Ways)
        
        override this.ToString () =
            let mutable s = sprintf "\t<relation id='%d' visible='%s' version='1'>\n" this.Id (if this.Visible then "true" else "false")
            //for node in this.Nodes do s <- s + (sprintf "\t\t<member type='node' ref='%d' role=''/>\n" node)
            for (way,role) in this.Ways do 
                s <- s + (sprintf "\t\t<member type='way' ref='%d' role='%s' />\n" way (role.ToString ()))
            (s + this.TagsToString () + "\t</relation>\n")
            
