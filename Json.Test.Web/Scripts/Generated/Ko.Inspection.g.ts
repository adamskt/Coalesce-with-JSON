
/// <reference path="../coalesce.dependencies.d.ts" />

// Generated by IntelliTect.Coalesce

module ViewModels {
    
    /** External Type Inspection */
    export class Inspection {
        public parent: any;
        public parentCollection: any;
        
        // Observables
        public inspectionId: KnockoutObservable<number | null> = ko.observable(null);
        public parentFieldWork: KnockoutObservable<ViewModels.FieldWork | null> = ko.observable(null);
        public metaData: KnockoutObservable<ViewModels.AuditMetaData | null> = ko.observable(null);
        
        /** 
            Load the object from the DTO.
            @param data: The incoming data object to load.
        */
        public loadFromDto = (data: any) => {
            if (!data) return;
            
            // Load the properties.
            this.inspectionId(data.inspectionId);
            if (!this.parentFieldWork()){
                this.parentFieldWork(new FieldWork(data.parentFieldWork, this));
            } else {
                this.parentFieldWork()!.loadFromDto(data.parentFieldWork);
            }
            if (!this.metaData()){
                this.metaData(new AuditMetaData(data.metaData, this));
            } else {
                this.metaData()!.loadFromDto(data.metaData);
            }
            
        };
        
        /** Saves this object into a data transfer object to send to the server. */
        public saveToDto = (): any => {
            var dto: any = {};
            
            dto.inspectionId = this.inspectionId();
            
            return dto;
        }
        
        constructor(newItem?: any, parent?: any) {
            this.parent = parent;
            
            if (newItem) {
                this.loadFromDto(newItem);
            }
        }
    }
}
