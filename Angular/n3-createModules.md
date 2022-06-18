<h2 align="center"> Module </h2>

- create a multiple modules and configuration:
  - ng g m region
  - cd src/app/region
  - ng g c add-region
  - new file: region-routing.module.ts
```
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AddRegionComponent } from "./add-region/add-region.component";
import { ListRegionComponent } from "./list-region/list-region.component";

const routes: Routes=[
    {path:'list', component:ListRegionComponent},
    {path:'add', component:AddRegionComponent}
]

@NgModule({
    imports:[RouterModule.forChild(routes)]
})
export class RegionRoutingModule{

}
```
- region.module.ts: import RegionRoutingModule
- 
