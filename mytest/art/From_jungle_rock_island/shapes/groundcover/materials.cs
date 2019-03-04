
singleton Material(grass_field)
{
    mapTo = "grass_field";
    diffuseMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/grass_field.dds";
    normalMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/normalsfix.dds";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "120";
    materialTag1 = "beamng";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag3 = "Natural";
    useAnisotropic[0] = "1";
};

singleton Material(plants_grasses)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "plants_grasses.dds";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "140";
    materialTag1 = "beamng";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag3 = "Natural";
};


singleton Material(BNG_Grass_Tall)
{
    mapTo = "unmapped_mat";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "107";
    doubleSided = "1";
    specularPower[0] = "1";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "0";
   colorMap[0] = "grass_field_long.dds";
   materialTag3 = "Natural";
   materialTag4 = "RoadAndPath";
};

singleton Material(BNG_Grass_03)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/Grass03_tropical_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "107";
    doubleSided = "1";
    specularPower[0] = "1";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "0";
};

singleton Material(lush_vegetation)
{
    mapTo = "lush_vegetation";
    diffuseMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/lush_vegetation_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "107";
    doubleSided = "1";
    specularPower[0] = "61";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "1";
    specularMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/lush_vegetation_s.dds";
    materialTag3 = "Natural";
    subSurface[0] = "0";
    subSurfaceColor[0] = "0.858824 1 0 1";
    subSurfaceRolloff[0] = "0.5";
    normalMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/lush_vegetation_n.dds";
    specularStrength[0] = "0.294118";
};

singleton Material(lush_vegetation_bb)
{
    mapTo = "unmapped_mat";
    diffuseMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/lush_vegetation_d.dds";
    materialTag0 = "beamng";
    materialTag1 = "vegetation";
    alphaTest = "1";
    alphaRef = "87";
    doubleSided = "1";
    specularPower[0] = "8";
    materialTag2 = "vegetation";
    useAnisotropic[0] = "0";
    materialTag3 = "Natural";
    subSurface[0] = "0";
    subSurfaceColor[0] = "1 0.2 0.2 1";
    subSurfaceRolloff[0] = "0.2";
    castShadows = "0";
    diffuseColor[0] = "0.968628 0.866667 0.952941 1";
    minnaertConstant[0] = "-1";
};

singleton Material(BNGGrass)
{
    mapTo = "unmapped_mat";
    diffuseColor[0] = "0.996078 0.996078 0.996078 1";
    useAnisotropic[0] = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "127";
    materialTag0 = "beamng";
    materialTag2 = "vegetation";
    materialTag1 = "vegetation";
   colorMap[0] = "levels/Mytest/art/From_jungle_rock_island/art/shapes/groundcover/grass_field_sml.dds";
   materialTag3 = "Natural";
};
