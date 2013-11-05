namespace StreetsGen.StreetsGraph   

    type Type =
        | Route
        | MultiPolygon
        | Boundary
        | Waterway
        override this.ToString () =
            match this with
                | Route -> "route"
                | MultiPolygon -> "multipolygon"
                | Boundary -> "boundary"
                | Waterway -> "waterway"
    
    type PolarReply =
        | Yes
        | No
        override this.ToString () =
            match this with
                | Yes -> "yes"
                | No -> "no"

    type Highway =
        | Residential
        | Primary
        | PrimaryLink
        | Secondary
        | SecondaryLink
        | Tertiary
        | TertiaryLink
        | LivingStreet
        | Pedestrian
        | Unclassified
        | Service
        | Track
        override this.ToString () =
            match this with
                | Residential -> "residential"
                | Primary -> "primary"
                | PrimaryLink -> "primary_link"
                | Secondary -> "secondary"
                | SecondaryLink -> "secondary_link"
                | Tertiary -> "tertiary"
                | TertiaryLink -> "tertiary_link"
                | LivingStreet -> "living_street"
                | Pedestrian -> "pedestrian"
                | Unclassified -> "unclassified"
                | Service -> "service"
                | Track -> "track"
    
    type Boundary =
        | Administrative
        | NationalPark
        override this.ToString () =
            match this with
                | Administrative -> "administrative"
                | NationalPark -> "national_park"
               
                            
    type LandUse =
        | Vineyard 
        | Grass
        | Allotments
        | Residential
        | Industrial
        override this.ToString () =
            match this with
                | Vineyard -> "vineyard"
                | Grass -> "grass"
                | Residential -> "residential"
                | Industrial -> "industrial"
                | Allotments -> "allotments"
    
    type Natural =
        | Scrub
        | Land
        | Water
        | Wood
        override this.ToString () =
            match this with
                | Scrub -> "scrub"
                | Land -> "land"
                | Water -> "water"
                | Wood -> "wood"
                                            
    type Tag =
        | Name of string
        | Elevation of int
        | Height of int
        | Type of Type   
        | Lanes of int
        | Oneway of PolarReply
        | Highway of Highway
        | Boundary of Boundary
        | LandUse of LandUse
        | Natural of Natural
        override this.ToString () =
            match this with
                | Name s -> sprintf "<tag k='name' v='%s' />" s
                | Type r -> sprintf "<tag k='type' v='%s' />" (r.ToString ())
                | Oneway r -> sprintf "<tag k='oneway' v='%s' />" (r.ToString ())
                | Highway h -> sprintf "<tag k='highway' v='%s' />" (h.ToString ())
                | Boundary b -> sprintf "<tag k='boundary' v='%s' />" (b.ToString ())
                | LandUse b -> sprintf "<tag k='landuse' v='%s' />" (b.ToString ())
                | Natural b -> sprintf "<tag k='natural' v='%s' />" (b.ToString ())
                | Elevation i -> sprintf "<tag k='ele' v='%d' />" i
                | Height i -> sprintf "<tag k='height' v='%d' />" i
                | Lanes i -> sprintf "<tag k='lanes' v='%d' />" i
        
