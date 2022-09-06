import { MediumType } from "./MediumType";
import { MediaGroupModel } from "./MediaGroupModel";

export interface MediaModel {
    type: MediumType;
    owner: string;
    serialNumber: string;
    description: string;
    group: MediaGroupModel;
    searchWeight: number;
}