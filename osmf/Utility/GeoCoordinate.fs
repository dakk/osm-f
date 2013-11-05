namespace StreetsGen.Utility
    open System
    
    ///<summary>GeoCoordinate</summary>
    type GeoCoordinate (?lat, ?lon) =
        let EarthRadius = 6360.0
        member val Latitude  : double = defaultArg lat 0.0 with get,set
        member val Longitude : double = defaultArg lon 0.0 with get,set
        
        ///<summary>Get the GeoCoordinate starting from this point and after (xm,ym) meters</summary>
        member this.AtOffset ((xm:float),(ym:float)) =
            let offsetLatitude = this.Latitude + (double ym) / EarthRadius;
            let offsetLongitude = this.Longitude + (double xm) / (EarthRadius * cos(offsetLatitude * Math.PI / 180.0))
            new GeoCoordinate (offsetLatitude, offsetLongitude)
        