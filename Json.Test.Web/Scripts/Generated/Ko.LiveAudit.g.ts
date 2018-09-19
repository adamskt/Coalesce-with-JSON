
/// <reference path="../coalesce.dependencies.d.ts" />

// Generated by IntelliTect.Coalesce

module ViewModels {
    
    export class LiveAudit extends Coalesce.BaseViewModel {
        public readonly modelName = "LiveAudit";
        public readonly primaryKeyName = "inspectionId";
        public readonly modelDisplayName = "Live Audit";
        public readonly apiController = "/LiveAudit";
        public readonly viewController = "/LiveAudit";
        
        /** Configuration for all instances of LiveAudit. Can be overidden on each instance via instance.coalesceConfig. */
        public static coalesceConfig: Coalesce.ViewModelConfiguration<LiveAudit>
            = new Coalesce.ViewModelConfiguration<LiveAudit>(Coalesce.GlobalConfiguration.viewModel);
        
        /** Configuration for the current LiveAudit instance. */
        public coalesceConfig: Coalesce.ViewModelConfiguration<this>
            = new Coalesce.ViewModelConfiguration<LiveAudit>(LiveAudit.coalesceConfig);
        
        /** The namespace containing all possible values of this.dataSource. */
        public dataSources: typeof ListViewModels.LiveAuditDataSources = ListViewModels.LiveAuditDataSources;
        
        
        public liveAuditQuestion1: KnockoutObservable<boolean | null> = ko.observable(null);
        public liveAuditQuestion2: KnockoutObservable<boolean | null> = ko.observable(null);
        public inspectionId: KnockoutObservable<number | null> = ko.observable(null);
        public parentFieldWork: KnockoutObservable<ViewModels.FieldWork | null> = ko.observable(null);
        public _MetaData: KnockoutObservable<string | null> = ko.observable(null);
        public metaData: KnockoutObservable<ViewModels.AuditMetaData | null> = ko.observable(null);
        
        
        /** Display text for ParentFieldWork */
        public parentFieldWorkText: KnockoutComputed<string>;
        
        /** Display text for MetaData */
        public metaDataText: KnockoutComputed<string>;
        
        
        
        
        
        
        /** 
            Load the ViewModel object from the DTO.
            @param data: The incoming data object to load.
            @param force: Will override the check against isLoading that is done to prevent recursion. False is default.
            @param allowCollectionDeletes: Set true when entire collections are loaded. True is the default. 
            In some cases only a partial collection is returned, set to false to only add/update collections.
        */
        public loadFromDto = (data: any, force: boolean = false, allowCollectionDeletes: boolean = true): void => {
            if (!data || (!force && this.isLoading())) return;
            this.isLoading(true);
            // Set the ID 
            this.myId = data.inspectionId;
            this.inspectionId(data.inspectionId);
            // Load the lists of other objects
            if (!data.parentFieldWork) { 
                this.parentFieldWork(null);
            } else {
                if (!this.parentFieldWork()){
                    this.parentFieldWork(new FieldWork(data.parentFieldWork, this));
                } else {
                    this.parentFieldWork()!.loadFromDto(data.parentFieldWork);
                }
            }
            if (!data.metaData) { 
                this.metaData(null);
            } else {
                if (!this.metaData()){
                    this.metaData(new AuditMetaData(data.metaData, this));
                } else {
                    this.metaData()!.loadFromDto(data.metaData);
                }
            }
            
            // The rest of the objects are loaded now.
            this.liveAuditQuestion1(data.liveAuditQuestion1);
            this.liveAuditQuestion2(data.liveAuditQuestion2);
            this._MetaData(data._MetaData);
            if (this.coalesceConfig.onLoadFromDto()){
                this.coalesceConfig.onLoadFromDto()(this as any);
            }
            this.isLoading(false);
            this.isDirty(false);
            if (this.coalesceConfig.validateOnLoadFromDto()) this.validate();
        };
        
        /** Saves this object into a data transfer object to send to the server. */
        public saveToDto = (): any => {
            var dto: any = {};
            dto.inspectionId = this.inspectionId();
            
            dto.liveAuditQuestion1 = this.liveAuditQuestion1();
            dto.liveAuditQuestion2 = this.liveAuditQuestion2();
            dto._MetaData = this._MetaData();
            
            return dto;
        }
        
        /** 
            Loads any child objects that have an ID set, but not the full object.
            This is useful when creating an object that has a parent object and the ID is set on the new child.
        */
        public loadChildren = (callback?: () => void): void => {
            var loadingCount = 0;
            if (loadingCount == 0 && typeof(callback) == "function") { callback(); }
        };
        
        public setupValidation(): void {
            if (this.errors !== null) return;
            this.errors = ko.validation.group([
            ]);
            this.warnings = ko.validation.group([
            ]);
        }
        
        constructor(newItem?: object, parent?: Coalesce.BaseViewModel | ListViewModels.LiveAuditList) {
            super(parent);
            this.baseInitialize();
            const self = this;
            
            this.parentFieldWorkText = ko.pureComputed(function() {
                if (self.parentFieldWork() && self.parentFieldWork()!.fieldWorkId()) {
                    return self.parentFieldWork()!.fieldWorkId()!.toString();
                } else {
                    return "None";
                }
            });
            this.metaDataText = ko.pureComputed(function() {
                if (self.metaData() && self.metaData()!.question1()) {
                    return self.metaData()!.question1()!.toString();
                } else {
                    return "None";
                }
            });
            
            
            
            
            
            self.liveAuditQuestion1.subscribe(self.autoSave);
            self.liveAuditQuestion2.subscribe(self.autoSave);
            self._MetaData.subscribe(self.autoSave);
            
            if (newItem) {
                self.loadFromDto(newItem, true);
            }
        }
    }
    
    export namespace LiveAudit {
    }
}
