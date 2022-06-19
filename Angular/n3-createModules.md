<h2 align="center"> Module </h2>

- create a multiple modules and configuration:
  - 1. create new model: ng g m region 
  - change directory: cd src/app/region
  - 2. app.module.ts: imports: RegionModule
  - 3. create new component: ng g c add-region
  - 4. create a routing file: region-routing.module.ts
    - create routes
    - @ngModel
    - export class RegionRoutingModule{} 
  - 5. region.module.ts: import RegionRoutingModule
  - 6. app-routing.module.ts:  {path:'region', loadChildren: () => import('./region/region.module').then(m=>m.RegionModule) },
