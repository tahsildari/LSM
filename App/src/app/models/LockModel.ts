import { LockType } from "./lockType";
import { LockBuildingModel } from "./LockBuildingModel";

export interface LockModel {
    type: LockType;
    name: string;
    serialNumber: string;
    floor: string;
    roomNumber: string;
    description: string;
    searchWeight: number;
    building: LockBuildingModel;
}