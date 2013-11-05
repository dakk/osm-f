namespace osmf.StreetsGraph        

    type MapObject (id:int, visible:bool) = 
        member val public Id        : int = id            with get, set
        member val public Visible   : bool = visible      with get, set
        member val public Tags      : Tag list = []       with get, set
        
        member this.AddTag (t:Tag) =
            this.Tags <- t::(this.Tags)
            
        member this.TagsToString () =
            let mutable s = ""
            for tag in this.Tags do s <- s + "\t\t" + (tag.ToString ()) + "\n"
            s
                
