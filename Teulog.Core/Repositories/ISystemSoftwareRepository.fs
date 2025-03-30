namespace Teulog.Core.Repositories

open System
open Teulog.Core.Entities

type ISystemSoftwareRepository =
    abstract AddAsync: SystemSoftware -> Async<unit>
    abstract GetByIdAsync: Guid -> Async<SystemSoftware option>
    abstract GetAllAsync: unit -> Async<SystemSoftware list>
    abstract UpdateAsync: SystemSoftware -> Async<unit>
    abstract DeleteAsync: SystemSoftware -> Async<unit>
