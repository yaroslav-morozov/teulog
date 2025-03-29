namespace Teulog.Core.Repositories

open System
open Teulog.Core.Entities

type ISystemSoftwareRepository =
    abstract Add: SystemSoftware -> unit
    abstract GetById: Guid -> SystemSoftware
    abstract GetAll: unit -> SystemSoftware list
    abstract Update: SystemSoftware -> unit
    abstract Delete: SystemSoftware -> unit
