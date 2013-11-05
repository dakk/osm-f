namespace StreetsGen.StreetsGraph
    open System
    open StreetsGen.Utility
    
    type Node (id:int, visible:bool, ?coord:GeoCoordinate) = 
        inherit MapObject (id, visible)
        
        member val Coordinate : GeoCoordinate = defaultArg coord (new GeoCoordinate ())

        override this.ToString () =
            let s = String.Format ( "\t<node id='{0}' visible='{1}' lat='{2}' lon='{3}' version='1'>\n", 
                                this.Id, (if this.Visible then "true" else "false"), 
                                this.Coordinate.Latitude, this.Coordinate.Longitude)          
            //let mutable s = sprintf "\t<node id='%d' visible='%s' lat='%f' lon='%f' version='1'>\n" 
            //                    this.Id (if this.Visible then "true" else "false") 
            //                    this.Coordinate.Latitude this.Coordinate.Longitude
            (s + this.TagsToString () + "\t</node>\n")