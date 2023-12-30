# DBMS
class Process {
    int pid;
    int arrivalTime;
    int priority;
    int cpuTime;
    int processTime;
    int memory;
    int printers;
    int scanners;
    int modems;
    int cds;
    String status;

    public int getPid() {
        return pid;
    }

    public void setPid(int pid) {
        this.pid = pid;
    }

    public int getArrivalTime() {
        return arrivalTime;
    }

    public void setArrivalTime(int arrivalTime) {
        this.arrivalTime = arrivalTime;
    }

    public int getPriority() {
        return priority;
    }

    public void setPriority(int priority) {
        this.priority = priority;
    }

    public int getCpuTime() {
        return cpuTime;
    }

    public void setCpuTime(int cpuTime) {
        this.cpuTime = cpuTime;
    }

    public int getProcessTime() {
        return processTime;
    }

    public void setProcessTime(int processTime) {
        this.processTime = processTime;
    }

    public int getMemory() {
        return memory;
    }

    public void setMemory(int memory) {
        this.memory = memory;
    }

    public int getPrinters() {
        return printers;
    }

    public void setPrinters(int printers) {
        this.printers = printers;
    }

    public int getScanners() {
        return scanners;
    }

    public void setScanners(int scanners) {
        this.scanners = scanners;
    }

    public int getModems() {
        return modems;
    }

    public void setModems(int modems) {
        this.modems = modems;
    }

    public int getCds() {
        return cds;
    }

    public void setCds(int cds) {
        this.cds = cds;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public Process(int pid, int arrivalTime, int priority, int cpuTime, int memory,
                   int printers, int scanners, int modems, int cds) {
        this.pid = pid;
        this.arrivalTime = arrivalTime;
        this.priority = priority;
        this.cpuTime = cpuTime;
        this.processTime = cpuTime;
        this.memory = memory;
        this.printers = printers;
        this.scanners = scanners;
        this.modems = modems;
        this.cds = cds;
        this.status = "WAITING";
    }




    @Override
    public String toString() {
        return String.format("%-4d%-4d%-7d%-5d%-8d%-6d%-6d%-6d%-6d%-12s",
                pid, arrivalTime, priority, cpuTime, memory, printers, scanners, modems, cds, status);
    }


    /*
     @Override
    public String toString() {
        switch (status) {
            case "DELETED":
                return pid + " HATA - Proses çok sayıda kaynak talep ediyor - proses silindi";
            case "TIME_EXCEEDED":
                return pid + " HATA - Proses zaman aşımı (20 sn de tamamlanamadı)";
            case "RUNNING":
                return pid + " " + arrivalTime + " " + priority + " " + cpuTime + " " + memory + " "
                        + printers + " " + scanners + " " + modems + " " + cds + " " + status;
            case "COMPLETED":
                return pid + " COMPLETED";
            default:
                return pid + " UNKNOWN STATUS";
        }
    }
     */
}
